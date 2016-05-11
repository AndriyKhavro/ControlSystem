(function(angular) {
    angular.module('controlSystem').filter('stopwatchTime', function() {
        return function(input) {
            if (input) {

                var elapsed = input.getTime();
                var hours = parseInt(elapsed / 3600000, 10);
                elapsed %= 3600000;
                var mins = parseInt(elapsed / 60000, 10);
                elapsed %= 60000;
                var secs = parseInt(elapsed / 1000, 10);
             
                return hours + ':' + mins + ':' + secs;
            }
        };
    });
}(angular));