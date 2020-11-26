const { Router } = require('express');
const router = Router();
const path = require('path');

router.get('/', (req, res) => {

    res.sendFile(path.join(__dirname + '/Desktop/cancelarServicio.html'));
});

router.post('/', (req, res) => {
    console.log(req.body);
    res.send('resivido- Servicio cancelado');
});

module.exports = router;