(function (angular) {
    angular.module('controlSystem').directive('rate', function () {
        
        return {
            templateUrl: 'ui/common/rate.html',
            scope: {
                rate: "="
            },
            controller: rateController,
            controllerAs: "rateCtrl",
            bindToController: true
        }

        function rateController(rateValues) {
            var vm = this;
            vm.max = 5;
            vm.isReadOnly = false;
            vm.rate = vm.rate || 4.7; 

            vm.onHover = function (value) {
                vm.value = vm.isReadOnly ? vm.rate.toFixed(2) : value;
                vm.displayValue = vm.isReadOnly ? vm.rate.toFixed(2) : _.invert(rateValues)[value];
            };
            vm.onLeave = function () {
                vm.value = "";
                vm.displayValue = "";
            };
        }
    });
}(angular));