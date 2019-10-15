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
        //Função trim trata strings removendo espaços desnecessários entre as palavrasm
        //ltrim (Remove espaços do início da esquerda para direita)
        //rtrim (Remove espaços do final da direita para esquerda)

        $nome = "   Jose da Silva   ";
        echo(strlen($nome));
        echo "<br/>";
        $novo = trim($nome);
        echo (strlen($novo));

    ?>
</body>
</html>