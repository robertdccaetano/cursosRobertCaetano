<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>

    <style>
        span.notas {
            color: red;
            font-weight: bold;
        }

    </style>
</head>
<body>
    <?php
        $n1 = isset($_GET["nota1"])?$_GET["nota1"]:"sem nota1";
        $n2 = isset($_GET["nota2"])?$_GET["nota2"]:"sem nota2";
        $media = ($n1 + $n2) / 2;

        echo "A média entre <span class='notas'> ". number_format($n1, 2)." </span> e <span class='notas'> ".number_format($n2, 2) ." </span> é igual a <span class='notas'> $media </span>";

        if ($media >= 0 && $media < 5) {
            $color = "red"; 
            echo "<br/>Situação do aluno : <span class='notas'>REPROVADO</span>";
        }
        elseif ($media >= 5 && $media < 7) {
            $color = "orange";
            echo "<br/>Situação do aluno: <span class='notas'>RECUPERAÇÃO</span>";
        }
        elseif ($media >= 7 && $media <= 10) {
            $color = "green";
            echo "<br/>Situação do aluno: <span class='notas'>APROVADO</span>";
        }
        else {
            echo"<br/><span class='notas'>VALORES DE NOTAS INCORRETO</span>";
        }
                
        ?>
</body>
</html>