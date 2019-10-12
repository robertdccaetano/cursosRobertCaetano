<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>

    <?php
        $txt = isset($_GET["t"])?$_GET["t"]:"Texto genérico";
        $cor = isset($_GET["cor"])?$_GET["cor"]:"#000";
        $tam = isset($_GET["tam"])?$_GET["tam"]:"12pt";
    ?>

    <style>
            span.texto {
                font-size: <?php echo $tam; ?>;
                color: <?php echo $cor; ?>;
            }
    </style>

</head>
<body>

    <?php
        echo "<span class='texto'> $txt </span>";
    ?>

    <a href="aula08IntegrandoPHPComHTML.html">Voltar</a>
    
</body>
</html>