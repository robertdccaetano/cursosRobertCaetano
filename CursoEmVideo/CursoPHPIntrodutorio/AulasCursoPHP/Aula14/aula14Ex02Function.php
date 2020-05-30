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
    //A função retorna valor
         function soma ($a, $b){
            // $s = $a + $b;
            //Retornar expressões é mais simples e torna mais leve o programa
            return $a + $b;
        }
        $x = -4;
        $y = 8;
        $resultado = soma($x, $y);
        echo "A soma entre $x e $y é igual a $resultado";
?>
</body>
</html>