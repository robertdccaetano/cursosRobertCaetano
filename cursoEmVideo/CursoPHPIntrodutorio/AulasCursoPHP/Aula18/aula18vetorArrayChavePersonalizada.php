<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 18 Vetor</title>
</head>
<body>
    <pre>
        <?php
            $v = array(1 => "A",
                       3 => "B",
                       6 => "C",
                       8 => "D");
            $v[] = "E";
            //Unset significa desalocar da memória a posição citada do vetor
            // unset($v[9]);
            unset($v[1]);
            print_r($v);

        ?>
    </pre>

</body>
</html>