<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <?php
    $frase = "Estou aprendendo PHP";

    $pos = stripos($frase, "php");

    echo "$frase <br/> A string foi encontrada na posição $pos";
    

    ?>
</body>
</html>