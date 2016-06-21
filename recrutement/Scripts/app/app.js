'use strict';
var app = angular.module('app', ['ngRoute','ngResource']);

app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
        .when('/', {
            controller: 'ListController',
            templateUrl: '/Templates/Candidat.html'
        })
        .when('/Candidat/Add',{
        controller:'AddController',
        templateUrl: '/Templates/Add.html'
        });

    //$locationProvider.html5Mode({
    //    enabled: true,
    //    requireBase: false
    //});
}]);

//myApp.run(function ($rootScope) {
//    $rootScope.message = "hello angular!";
//});

