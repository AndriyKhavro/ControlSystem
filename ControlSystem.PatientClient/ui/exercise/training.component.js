﻿(function (angular) {
    'use strict';

    angular.module('controlSystem').component('training', {
        templateUrl: 'ui/exercise/training.html',
        controller: TrainingController
    });

    TrainingController.$inject = ['currentStateService', 'controlSystem.stopwatch'];

    function TrainingController(currentStateService, Stopwatch) {
        var vm = this;
        var stopwatch;
        vm.currentState = currentStateService.currentState;

        vm.isLoaded = false;
        vm.isStarted = false;
        vm.startExercise = function() {
            vm.options = {};
            stopwatch = new Stopwatch(vm.options);
            stopwatch.startTimer();
            vm.isStarted = true;
        };

        vm.finishExercise = function () {
            vm.currentState.currentAssignment.time = _formatTime(vm.options.elapsedTime);
            stopwatch.resetTimer();
            currentStateService.finishExercise();
        }

        

        function _formatTime(dateTime) {
            return dateTime.getUTCHours() + ':' + dateTime.getUTCMinutes() + ':' + dateTime.getUTCSeconds();
        }

        currentStateService.startTraining().then(function () {
            vm.isLoaded = true;
        });
    }

}(angular));
