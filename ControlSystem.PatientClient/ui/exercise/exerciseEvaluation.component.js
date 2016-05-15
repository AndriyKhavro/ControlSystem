(function (angular) {
    'use strict';

    angular.module('controlSystem').component('exerciseEvaluation', {
        templateUrl: 'ui/exercise/exerciseEvaluation.html',
        controller: ExerciseEvaluation,
        bindings: {
            exercise: '='
        }
    });

    ExerciseEvaluation.$inject = ['constant', 'currentStateService'];

    function ExerciseEvaluation(constant, currentStateService) {
        var ctrl = this;
        ctrl.evaluation = {};
        ctrl.feeling = constant.feeling;

        ctrl.goToNextExercise = function() {
            currentStateService.goToNextExercise({
                exerciseAssignmentId: ctrl.exercise.exerciseAssignmentId,
                grade: ctrl.evaluation.grade,
                feeling: ctrl.evaluation.feeling,
                time: ctrl.exercise.time
            });
        };
    }

}(angular));
