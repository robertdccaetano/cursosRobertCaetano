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
        $v = array("a", "j", "m", "x", "k");
        print_r($v);
        //Tratamento estrutras de dados colocando valor no indice final do vetor $n
        array_push($v, 7);
        print_r($v);
        //array_pop desaloca último elemento do vetor
        array_pop($v);
        print_r($v);

        //Insere o valor 7 no índiceposição 0 do vetor
        array_unshift($v, 7);
        print_r($v);

        //Remove o valor do índice 0 no vetor
        array_shift($v);
        print_r($v);
?>
    </pre>
</body>
</html>