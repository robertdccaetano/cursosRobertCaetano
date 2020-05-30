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
    //A função que nao retorna valor é chamado de PROCEDIMENTO
    function soma ($a, $b){
        $s = $a + $b;
        echo "<p>A soma vale $s</p>";
    }
    soma(3,4);
    soma(8,2);
    $x = 9;
    $y = 15;    
    soma($x, $y);

    ?>

</body>
</html>