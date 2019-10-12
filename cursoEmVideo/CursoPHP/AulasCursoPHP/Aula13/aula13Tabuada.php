<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Aula 13 Repeticao Tabuada</title>
</head>
<body>
    <div>
        <form method="get" action="aula13Ex02.php">
            <select name="num" id="">
                <?php
                    for($c = 1; $c <= 10; $c++) {
                        echo "<option>$c</option>";
                    }
                ?>
            </select>

            <input type="submit" value="Tabuada" />
        
        </form>
    </div>
    
</body>
</html>