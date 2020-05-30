<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 05 Operações aritméticas</title>
</head>
<body>

    <?php
        $n1 = $_GET["a"];
        $n2 = $_GET["b"];
        echo "<h2>Valores recebios por parâmetro: $n1 e $n2 </h2>";
        $media = ($n1 + $n2) / 2;
        echo "A soma entre $n1 e $n2 é igual a $s <br/>";
        // Para realizar operações dentro de comandos por exemplo o 'echo' é de acordo com o a linha abaixo
        echo "A soma vale ". ($n1 + $n2);
        echo "<br/> A subtração vale ". ($n1 - $n2);
        echo "<br/> A multiplicação vale ". ($n1 * $n2);
        echo "<br/> A divisão vale ". ($n1 / $n2);
        // echo "<br/> O modulo vale ". ($n1 % $n2);
        echo "<br/> A média vale $media";
        echo "<br/> A média vale ". (($n1 + $n2) / 2 );

        // Funções matemáticas (aritmeticas)
        $v1 = $_GET["x"];
        $v2 = $_GET["y"];
        echo "<h2>Os valores recebidos: $v1 e $v2</h2>";
        echo "<br/> Valor absoluto de $v1 é ". abs($v1);
        echo "<br/> O valor de $v1 elevado a $v2 é ". pow($v1, $v2);
        echo "<br/> A raiz quadrada de $v1 é ". sqrt($v1);
        echo "<br/> O valor de de $v2 arredondado é ". round($v2); //ceil (céu) arredonda pra cima e floor arredonda sempre pra baixo
        echo "<br/> A parte inteira de $v2 é ". intval($v2); //Pega somente intervalo inteiro
        echo "<br/> O valor de $v1 em moeda é R$". number_format($v1, 2, ",", ".");

        //Parametros na URL
        //Através do $_GET[" "]; pega valores do parâmetro na URL
        // .php?a=5&b=8
    ?>

</body>
</html>