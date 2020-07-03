<?php

require __DIR__."/../vendor/autoload.php";

use Source\Models\User;



$user = (new User())->findByID(16);
$user->first_name = "Pedro";
$user->save();

echo "<pre>",
var_dump($user),
     "</pre>";
