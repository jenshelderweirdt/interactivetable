# How to use Interactive Table V2

More information: http://l-lin.github.io/angular-datatables/#/api

## 1. Angular datatables binnenhalen met bower

```
bower install angular-datatables --save
```

## 2. References juistzetten in index.cshtml (enkel diegene die je nodig hebt)

```html
Styles 
<link rel="stylesheet" href="http://cdn.datatables.net/1.10.12/css/jquery.dataTables.min.css">
<link rel="stylesheet" href="https://cdn.datatables.net/buttons/1.2.2/css/buttons.dataTables.min.css">

Scripts
<script src="https://cdn.datatables.net/colreorder/1.3.2/js/dataTables.colReorder.min.js"></script>
<script src="https://cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js"></script>
<script src="https://cdn.datatables.net/buttons/1.2.2/js/buttons.colVis.min.js"></script>
```

## 3. Tabel in html

```html
<table datatable="" dt-options="ctrl.dtOptions" dt-columns="ctrl.dtColumns" class="row-border hover"></table>
```

## 4. Configureren in javascript

```javascript
ctrl.dtOptions = DTOptionsBuilder.newOptions()
    .withButtons(['colvis'])
    .withOption('ajax', {
        dataSrc: "data",
        url: 'http://localhost:5001/api/people',
        type: 'POST'
    })
    .withOption("colReorder", true)
    .withOption("dom", "Bftilp")
    .withOption('processing', true)
    .withOption('serverSide', true)
    .withPaginationType('simple_numbers')
    .withDisplayLength(10)
    .withOption('aaSorting', [0, 'asc'])
    .withOption('searchDelay', 1000)
    .withLanguage({
        "sInfo": "<b>_START_</b> - <b>_END_</b> van <b>_TOTAL_</b> getoond",
        "sLengthMenu": "_MENU_ per pagina",
        "oPaginate": {
            "sNext": "<i class='fa fa-angle-right'></i>",
            "sPrevious": "<i class='fa fa-angle-left'></i>"
        },
        "buttons": {
            "colvis": "<i class='fa fa-columns'></i>"
        },
        "searchPlaceholder": "Zoeken",
        "search": "",
        "infoFiltered": "(gefilterd uit _MAX_ resultaten)"
    })
    .withOption('autoWidth', false)

    //fnServerParams is only needed when you want to add extra params to the API call
    .withOption('fnServerParams', extraParams)

    function extraParams(aoData) {
        aoData.extraFilter = "This can be any extra filter";
    }

ctrl.dtColumns = [
    DTColumnBuilder.newColumn('id', 'ID').withOption('name', 'id'),
    DTColumnBuilder.newColumn('firstName', 'First name').withOption('name', 'firstname'),
    DTColumnBuilder.newColumn('lastName', 'Last name').withOption('name', 'lastname').withOption('className', 'multiline'),
];
```

## 5. Styling toevoegen (dit komt later in aparte bower component met styling)

```css
.dataTables_length {
    margin-left: 1rem;
    padding-top: 0.755em;
    margin-top: 0;
}

div.dataTables_length select {
    width: auto;
}

div.dt-button-background {
    visibility:hidden;
}

.dataTables_filter input[type="search"] {
    padding: 1rem;
}

.multiline {
    word-break: break-word;
}
```

## 6. DataTableParameters model toevoegen

```cs
public class DataTableParameters
{
    public int Draw { get; set; }
    public int Start { get; set; }
    public int Length { get; set; }
    public Search Search { get; set; }
    public Order[] Order { get; set; }
    public Column[] Columns { get; set; }

    //this is only needed when you want to recieve extra params (can be any object)
    public string ExtraFilter { get; set; }
}

public class Order
{
    public int Column { get; set; }
    public string Dir { get; set; }
}

public class Column
{
    public string Data { get; set; }
    public string Name { get; set; }
    public bool Searchable { get; set; }
    public bool Orderable { get; set; }
    public Search Search { get; set; }
}

public class Search
{
    public string Value { get; set; }
    public bool Regex { get; set; }
}
```

## 7. API call toevoegen

```cs
[HttpPost]
public ActionResult GetPage([FromForm]DataTableParameters parameters)
{
    //DO CALLS TO BACKEND
    //FILTERED --> filtered with search_term of extra filters
    return Json(new { draw = parameters.Draw, recordsFiltered = FILTERED_RECORDS, recordsTotal = TOTAL_RECORDS, data = FILTERED_DATA });
}
```