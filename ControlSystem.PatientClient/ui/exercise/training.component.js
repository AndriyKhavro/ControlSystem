(function (angular) {
    'use strict';

    angular.module('controlSystem').component('training', {
        templateUrl: 'ui/exercise/training.html',
        controller: TrainingController
});

    TrainingController.$inject = ['controlSystem.exerciseService', 'controlSystem.stopwatch'];

    function TrainingController(exerciseService, Stopwatch) {
        var vm = this;
        vm.isLoaded = false;
        vm.isStarted = false;
        vm.startExercise = function () {
            vm.options = {};
            var stopwatch = new Stopwatch(vm.options);
            stopwatch.startTimer();
            vm.isStarted = true;
        }

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
