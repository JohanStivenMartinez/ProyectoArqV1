const { error } = require('console');
const { Router } = require('express');
const router = Router();
const path = require('path');

router.get('/', (req, res) => {

    res.sendFile(path.join(__dirname + '/Desktop/crearServicio.html'));
});

router.post('/', (req, res) => {

    console.log(req.body);
       res.send('resivido');
   
    
    
});

module.exports = router;