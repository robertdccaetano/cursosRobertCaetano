<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 06 operadors de atribuição</title>
</head>
<body>

    <?php
        //Operadores de atribuição
        //Exercício 01
        echo "<h3>Exercício 01 </h3>";
        $preco = $_GET["p"];
        echo "O preço do produto é R$ ". number_format($preco, 2, ",", ".");
        // $preco = $preco + ($preco * 10 / 100); //Atribuição com expressão mais longa modelo antigo
        // $preco += ($preco * 10 / 100); //Aumento
        $preco -= ($preco * 10 / 100); //Desconto
        echo "<br/>O novo preço com 10% de desconto será de R$ ". number_format($preco, 2, ",", "." );

        echo "<br/><br/><h3>Exercício 02 </h3>";
        //Exercício 02
        //Pré-incremento
        //Pós-incremento
        //Pré-decremento
        //Pós-decremento
        // Comentários em PHP (// # /* */)
        $atual = $_GET['aa']; #Essa linha pega o ano da URL
        echo "O ano atual é $atual e o ano anterior é ". --$atual;

        //Variáveis Referenciadas através do caractere (&) e comercial
        //Exercício 03
        echo "<br/><br/><h3>Exercício 03 </h3>";
        $a = 3;
        $b = &$a;
        echo "Anteriormente a variável B valia $b";
        $b += 5;
        echo "<br/>A variável A vale $a";
        echo "<br/>A variável B vale $b";

        //Variáveis das variáveis
        echo "<br/><br/><h3>Exercício 04 </h3>";
        $x = "abc";
        $$x = "def";
        echo "  O conteúdo da variável X é $x";
        echo "<br/>O conteúdo da variável indicada com apenas um $ se torna uma váriavel e recebe o valor da 
        variável atribuida com dois $ ABC criada recebeu o valor $abc";
    ?>
    
</body>
</html>