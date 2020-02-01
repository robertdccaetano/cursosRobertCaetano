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
        <table border="1"><tr>
        <?php
        //Comeca em 5 vai até 20 pulando 2 em 2 (passo)
            $c = range(5, 20 , 2);
            foreach($c as $v) {
                echo "<td>$v ";
            }
        ?>
        </table>
    </pre>

</body>
</html>