(function () {
    'use strict';
    var ctrlName = "HomeController";
    var theController = function (appService, DTOptionsBuilder, DTColumnBuilder) {

        appService.logger.creation(ctrlName);

        var ctrl = this;
        ctrl.titel = "InteractiveTableBootstrap";

        init();

        function init() {
            appService.logger.init(ctrlName);

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
                .withOption('fnServerParams', extraParams)

                function extraParams(aoData) {
                    aoData.extraFilter = "This can be any extra filter";
                }

            ctrl.dtColumns = [
                DTColumnBuilder.newColumn('id', 'ID').withOption('name', 'id'),
                DTColumnBuilder.newColumn('firstName', 'First name').withOption('name', 'firstname'),
                DTColumnBuilder.newColumn('lastName', 'Last name').withOption('name', 'lastname').withOption('className', 'multiline'),
            ];
        }
    };

    theController.$inject = ['AppService', 'DTOptionsBuilder', 'DTColumnBuilder'];
    angular.module('theApp').controller(ctrlName, theController);
})();