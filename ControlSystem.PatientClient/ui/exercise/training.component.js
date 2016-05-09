(function (angular) {
    'use strict';

    angular.module('controlSystem').component('training', {
        templateUrl: 'ui/exercise/training.html',
        controller: TrainingController
});

    TrainingController.$inject = ['controlSystem.exerciseService'];

    function TrainingController(exerciseService) {
        var vm = this;
        vm.isLoaded = false;

        vm.assignments = [];
        exerciseService.getAssignments()
            .then(function (response) {
                vm.assignments = response.data;
                if (vm.assignments.length > 0) {
                    vm.currentAssignment = vm.assignments[0];
                    vm.currentAssignment.number = 1;
                    vm.anyAssignments = true;
                } else {
                    vm.anyAssignments = false;
                }

                vm.isLoaded = true;
            });
    }

}(angular));
