<?php
for($i = 0; $i <= 10; $i ++) {
    if($i % 3 == 0){
        continue;
    }
    echo $i."-";
}
echo "Fim";


function f($v, $n) {
        if ($n <= 0) return 1;
        else
            return $v[$n - 1] * f($v, $n - 2) + 1;
        }
        $a = array(0, 1, 2, 3);
        print(f($a, 4));

        6
        7
        0
        5
        NULL

?>
