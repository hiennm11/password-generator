const resultEl = document.getElementById('result');
const clipboardEl = document.getElementById('clipboard');
const uppercaseEl = document.getElementById('uppercase');
const lowercaseEl = document.getElementById('lowercase');
const numbersEl = document.getElementById('numbers');
const symbolsEl = document.getElementById('symbols');
const buttonEl = document.getElementById('btnGenerate');
const lengthEl = document.getElementById('length');

const randomFunc = {
    lower: getRandomLower,
    upper: getRandomUpper,
    num: getRandomNum,
    sym: getRandomSymbol
};

function generatePassword(upper, lower, num, sym, length) {
    let generatedPassword = '';
    const typeCount = upper + lower + num + sym;

    const typeArr = [{ lower }, { upper }, { num }, { sym }].filter
    (
        item => Object.values(item)[0]
    );
        
    if(length <= 0 || typeCount === 0){
        return '';
    }

    for(let i = 0;i < length; i+= typeCount){
        typeArr.forEach(type => {
            const funcName = Object.keys(type)[0];
            generatedPassword += randomFunc[funcName]();
        });
    }

    return generatedPassword;
}

buttonEl.addEventListener('click', () => {
    const length = +lengthEl.value;
    const lower = lowercaseEl.checked;
    const upper = uppercaseEl.checked;
    const num = numbersEl.checked;
    const sym = symbolsEl.checked;

    resultEl.value = generatePassword(upper, lower, num, sym, length);
})

clipboardEl.addEventListener('click', ()=>{
    const textarea = document.createElement('textarea');
	const password = resultEl.value;
	
	if(!password) { return; }
	
	textarea.value = password;
	document.body.appendChild(textarea);
	textarea.select();
	document.execCommand('copy');
	textarea.remove();
	alert('Password copied to clipboard');
})

function getRandomLower() {
    return String.fromCharCode(Math.floor(Math.random() * 26) + 97);
}

function getRandomUpper() {
    return String.fromCharCode(Math.floor(Math.random() * 26) + 65);
}

function getRandomNum() {
    return String.fromCharCode(Math.floor(Math.random() * 10) + 48);
}

function getRandomSymbol() {
    const symbol = '!@#$%^&*(){}[]=<>/,.';
    return symbol[Math.floor(Math.random() * symbol.length)];
}

  
