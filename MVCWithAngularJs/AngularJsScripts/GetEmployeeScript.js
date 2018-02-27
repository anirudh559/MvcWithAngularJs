/// <reference path="../Scripts/angular.js" />


var myapp = angular
    .module("mymodule", [])
    .controller("Mycontroller", function ($scope,$http) {
        $http.get('http://localhost:51952/api/Customer/CustomerDetails')
        .then(function (response) {
            //alert(response.data)
            $scope.employees = response.data;
            //alert($scope.employees)
        })
    //$scope.message = "angular js tutorial";
});