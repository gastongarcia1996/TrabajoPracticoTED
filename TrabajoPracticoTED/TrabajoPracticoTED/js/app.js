var myApp = angular.module("myApp", []);
var flag = true;

myApp.controller('myController', function ($scope, $http)
{
    $scope.DtoSelAux = {};
    $scope.DtoSel = {};
    $scope.resultado = '';
    $scope.nombreUsuario = '';
    $scope.password = '';
    $scope.usuario = '';
    $scope.flagProyecto = 'F';
    $scope.flagObjetivos = 'F';
    $scope.login = 'Log';
    $scope.listaRespuestas = ["medula espinal", 'cerebelo', 'glandula pineal', 'plexo coroides', 'cerebro'
    , 'ventriculos', 'hipotalamo', 'nervio optico', 'hipofisis', 'protuberancia', 'bulbo raquideo'];

    $scope.Buscar = function ()
    {
        $http.get('/api/Usuarios' + '?nombre=' + $scope.nombreUsuario + '&password=' + $scope.password)
            .then(function (response) {
                $scope.usuario = response.data;// variable para luego imprimir 

                $scope.ValidarUsuario($scope.usuario);
            });         
    };

    $scope.Grabar = function ()
    {
        if ($("input[name=pass]").val() === $("input[name=passRepeat]").val())
        {
            $scope.DtoSel.nombre = $scope.DtoSelAux.nombre;
            $scope.DtoSel.contraseña = $scope.DtoSelAux.password;
            $http.post('/api/Usuarios', $scope.DtoSel).then(function (response)
            {
                $.alert({
                    title: 'Registro',
                    content: 'Usuario registrado correctamente',
                    theme: 'supervan',
                });
                $scope.login = 'Log';
            });
        }
        else
        {
            $.alert({
                title: 'Registro',
                content: 'Contraseñas distintas',
                theme: 'supervan',
            });
        }
    };

    $scope.ValidarUsuario = function (usuario)
    {
        if (usuario != '')
        {
            $(location).attr('href', 'menu.html');
        }
        else {
            $.alert({
                title: 'Error',
                content: 'Usuario o contraseña incorrectos',
                theme: 'supervan',
            });
        }
    }
    
    $scope.SetFlagProyectoTrue = function ()
    {
        $scope.flagProyecto = 'T';
    };

    $scope.SetFlagProyectoFalse = function ()
    {
        $scope.flagProyecto = 'F';
    };

    $scope.Validar = function ()
    {
        var i = 0;
        var cont = 0;
        $(document).ready(function ()
        {
            $("input").each(function (index, element)
            {
                if ($(element).val() === $scope.listaRespuestas[i])
                {
                    $(element).css("background-color", "lightgreen");
                    cont = cont + 1;
                }
                else $(element).css("background-color", "red");

                i = i + 1;
            });

            $.alert({
                title: 'Puntuacion',
                content: 'Tienes: ' + cont + ' / 11 correctas',
                theme: 'supervan',
            });
        });
    };

    $scope.Registrar = function ()
    {
        $scope.login = 'Reg';
    }
});