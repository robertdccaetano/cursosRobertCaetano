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
        $v = array("nome" => "ana", "idade" => 23, "peso" => 65.6 );
        $v["fuma"] = true;
        // print_r($v);]
        foreach($v as $k => $c) {
            echo "O campo $k possui o conteúdo $c <br/>";
        }

    ?>
    </pre>
</body>
</html>