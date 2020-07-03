<?php

namespace Source\Models;

use CoffeeCode\DataLayer\DataLayer;
use Source\Models\Address;
/**
 * Description of User
 *
 * @author robert
 */
class User extends DataLayer
{

    public function __construct()
    {
        parent::__construct("users", ["first_name", "last_name", "email", "passwd"]);
    }
    
//    public function save(): bool
//    {
//        //verifico email
//        parent::save();
//    }
    
    public function addresses()
    {
        
        return (new Address())->find("user_id = :uid", "uid={$this->id}")->fetch(true);
    }
}
