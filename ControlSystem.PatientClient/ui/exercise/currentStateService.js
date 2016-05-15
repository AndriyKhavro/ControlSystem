(function (angular) {
    'use strict';

    angular.module('controlSystem').service('currentStateService', currentStateService);

    currentStateService.$inject = ['exerciseService'];

    function currentStateService(exerciseService) {


        var currentState = {
            currentAssignment: null,
            anyAssignments: false,
            isExecuting: false,
            isTrainingFinished: false
        };

        this.currentState = currentState;
        this.startTraining = startTraining;
        this.finishExercise = finishExercise;
        this.goToNextExercise = goToNextExercise;

        var assignments;

        function startTraining() {

            return exerciseService.getAssignments()
                .then(function(response) {
                    assignments = response.data;
                    if (assignments.length > 0) {
                        currentState.currentAssignment = assignments[0];
                        currentState.currentAssignment.number = 1;
                        currentState.anyAssignments = true;
                        currentState.isExecuting = true;
                    } else {
                        currentState.anyAssignments = false;
                    }
                });
        }

        function finishExercise() {
            currentState.isExecuting = false;
        }

        function goToNextExercise (history) {
            exerciseService.addHistory(history);
            if (assignments.length <= currentState.currentAssignment.number) {
                currentState.isTrainingFinished = true;
            } else {
                var nextAssigment = assignments[currentState.currentAssignment.number];
                nextAssigment.number = currentState.currentAssignment.number + 1;
                currentState.currentAssignment = nextAssigment;
                currentState.isExecuting = true;
            }
        }
    }
}(angular));
