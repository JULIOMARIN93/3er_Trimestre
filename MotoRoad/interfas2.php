<?php
// iniciamos sesion para poder trabajar con la funcion 
session_start();
// si el usuario no a iniciado sesion se le alerte y redirige 
if(!isset($_SESSION['usuario'])){
    ?>
    <script>
        alert("debes iniciar sesion para poder ingresar a esta pagina ")
        window.location = './Formulario/inicioSesion/index.php'
    </script>
    <?php
    session_destroy(); // destruimos la sesion 
    die(); // detenemos todo 
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>interfas</title>
</head>
<body>
    <h1>bienvenidos conductor</h1>
    <a href="./cerrar_sesion.php">cerrar session</a>
</body>
</html>