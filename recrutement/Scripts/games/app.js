'use strict';

angular
.module('twentyfourtyeightApp', ['Game','ngRoute', 'Grid', 'Keyboard', 'ngAnimate', 'ngCookies'])
.config(function ($routeProvider, GridServiceProvider) {
    $routeProvider
.when('/2048', {
    controller: 'GameController',
    templateUrl: '/Templates/2048.html'
}).otherwise('/2048');

  GridServiceProvider.setSize(4);
})
.controller('GameController', function(GameManager, KeyboardService) {

  this.game = GameManager;

  this.newGame = function() {
    KeyboardService.init();
    this.game.newGame();
    this.startGame();
  };

  this.startGame = function() {
    var self = this;
    KeyboardService.on(function(key) {
      self.game.move(key);
    });
  };

  this.newGame();
});
