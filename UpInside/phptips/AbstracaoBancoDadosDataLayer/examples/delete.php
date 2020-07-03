<?php

require __DIR__."/../vendor/autoload.php";

use Source\Models\User;



$user = (new User())->findByID(16);

if ( $user ) {
    $user->destroy();
} else {
    echo "<pre>",
    var_dump($user),
         "</pre>";
}
