var app = angular.module('app', ['ngRoute']);

    app.config([function ($routeProvider, $locaionProvider) {
    $routeProvider
    .when('/contacts', {
        controller: 'ListController',
        template: 'Views/Home/Contact.html'
    });
    $locationProvider.html5Mode(true);
}]);

//myApp.run(function ($rootScope) {
//    $rootScope.message = "hello angular!";
//});

