<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 12 Repetição Do While</title>
</head>
<body>
    <?php
        $valor = isset($_GET["val"])?$_GET["val"]: 1;
        echo "<h1>Calculando o fatorial de $valor</h1>";
        $c = $valor;
        $fat = 1;
        do {
            $fat = $fat * $c;
            $c--;
        }while($c >= 1);
        echo "<h2>$valor ! = $fat</h2>"
    ?>
    <a href="javascript:history.go(-1)">Voltar</a>

</body>
</html>