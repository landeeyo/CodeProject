'use strict';

/**
 * @ngdoc overview
 * @name buildingReadableAppsWithDirectivesApp
 * @description
 * # buildingReadableAppsWithDirectivesApp
 *
 * Main module of the application.
 */
angular
  .module('buildingReadableAppsWithDirectivesApp', [
    'ngAnimate',
    'ngAria',
    'ngCookies',
    'ngMessages',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl'
      })
      .when('/about', {
        templateUrl: 'views/about.html',
        controller: 'AboutCtrl'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
