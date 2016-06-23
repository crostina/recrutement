//'use strict';
var app = angular.module('gamesApp', ['g2048',
                                      'Grid',
                                      'Keyboard',
                                      'ngRoute']);

app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
        .when('/2048', {
            controller: '2048Controller',
            templateUrl: '/Templates/2048.html'
        }).otherwise('/2048');

    //$locationProvider.html5Mode({
    //    enabled: true,
    //    requireBase: false
    //});
}]);


