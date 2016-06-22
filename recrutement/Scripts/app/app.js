//'use strict';
var app = angular.module('app', ['ngRoute','ngResource','ngMessages']);

app.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
        .when('/candidats', {
            controller: 'candidatController',
            templateUrl: '/Templates/Table.html'
        })
        .when('/candidat/add',{
        controller: 'addController',
        templateUrl: '/Templates/Add.html'
        })
        .when('/candidat/:id', {
            controller: 'singleController',
            templateUrl:'/Templates/single.html'
        }).otherwise('/candidats');

    //$locationProvider.html5Mode({
    //    enabled: true,
    //    requireBase: false
    //});
}]);


