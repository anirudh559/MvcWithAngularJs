/// <reference path="../Scripts/angular.js" />


var myapp = angular
    .module("mymodule", [])
    .controller("Mycontroller", function ($scope,$http) {
        $http.get('/Customer/GetCustomerDetails')
        .then(function (response) {
            //alert(response.data)
            $scope.employees = response.data;
            //alert($scope.employees)
        })
    //$scope.message = "angular js tutorial";
});