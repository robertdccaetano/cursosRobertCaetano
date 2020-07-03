<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 16 printr</title>
</head>
<body>
    <?php
    $v[0] = 4;
    $v[1] = 8;
    $v[2] = 3;

    //print_r útil para testes, mostrar detalhes da variáveis e vetores
    // print_r($v);
    // Esse simbolo ( => ) significa associação 

    $v2 = array (3,7,6,2,1,9);
    print_r($v2);   
    echo"<br/>";
    var_dump($v2);
    echo"<br/>";
    var_export($v2);
    ?>

</body>
</html>