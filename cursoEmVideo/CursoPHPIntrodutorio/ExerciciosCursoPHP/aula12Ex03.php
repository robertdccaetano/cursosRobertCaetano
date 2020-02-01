<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 12 Exercicio 03</title>
</head>
<body>
    <?php
     $valor = isset($_GET["numero"])?$_GET["numero"]: 1;

     echo "<h1>Mostrando a Tabuada de $valor</h1>";

     $c = 1;
     do{
         echo "<h3>$valor x $c = ".($valor * $c) ."</h3>";
         $c++;

     }while($c <= 10);
    ?>
    <a href="javascript:history.go(-1)">Voltar</a>
</body>
</html>