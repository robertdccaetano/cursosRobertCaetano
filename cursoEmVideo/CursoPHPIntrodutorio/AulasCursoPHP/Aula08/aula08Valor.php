<!DOCTYPE html>
<html lang="pt-bt">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 08 Integrando com HTML</title>
</head>
<body>

    <?php
    // <form method = "get" > - Usa-se $_GET["n"];
    // <form method = "post" > - Usa-se $_POST["n"];

        $valor = $_GET["v"];
        $rq = sqrt($valor);

        echo "A raiz de $valor é igual a ".number_format($rq, 2);
    ?>
    <a href="aula08IntegrandoPHPComHTML.html">Voltar</a>

</body>
</html>