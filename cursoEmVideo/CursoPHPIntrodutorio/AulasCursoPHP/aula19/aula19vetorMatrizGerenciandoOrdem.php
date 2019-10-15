<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body> 
<pre>
    <?php
        $v = array( 2=> "A", 5 => "J", 0 => "M", 3 => "X", 4 => "K");

        // print_r($v);
        // //Orden alfabeticamente e ascendente alphanumericos
        // sort($v);
        // print_r($v);

        // print_r($v);
        // //Ordena reversamente o vetor de forma descendente alphanuméricos e alfabética
        // rsort($v);
        // // print_r($v);

        // //Ordenação associativa mexe com os valores e também os índices
        // print_r($v);
        // asort($v);
        // print_r($v);

        // //Ordena reversamente o vetor e mantém os índices associativos
        // arsort($v);
        // print_r($v);

        print_r($v);
        //Ordena apenas os índices (as chaves dos valores)
        ksort($v);
        print_r($v);

        krsort($v);
        print_r($v);

?>
</pre>
</body>
</html>
