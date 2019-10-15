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
        //Idêntico -> === Três iguais
        //Operador Unário (expressao ? verdadeiro : falso)

        $n1 = $_GET["a"];
        $n2 = $_GET["b"];
        $tipo = $_GET["op"];
        echo "Os valore passados foram $n1 e $n2 <br/>";
        $r = ($tipo == "s") ? $n1+$n2 : $n1* $n2;
        echo "O resultado é $r";

        $a = 3;
        $b = "3";
        $r = ($a == $b) ? "SIM" : "NÃO";
        echo "<br/><br/>As variáveis A e B são iguais ? $r";

        //Exercício 03
        echo "<br/><br/><h2>Exercício 03</h2>";

        $nota1 = $_GET["n1"];
        $nota2 = $_GET["n2"];
        $m = ($nota1 + $nota2) / 2;
        echo "A média entre $nota1 e $nota2 é $m";
        echo "<br/>A situação do aluno é ".(($m < 6)?"REPROVADO":"APROVADO");

        echo "<br/><br/><h2>Exercício 04</h2>";
        $ano = $_GET["an"];
        $idade = 2019 - $ano;
        echo "Quem nasceu em $ano tem idade de $idade anos";
        $tipo =  ($idade >=18 && $idade <65)?"OBRIGATORIO":"DISPENSADO";
        echo "<br/>E dessa forma seu voto é $tipo";
    ?>
</body>
</html>