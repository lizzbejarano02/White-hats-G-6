const greeting = `
   _____ _       _     _______ _             
  / ____(_)     | |   |__   __| |            
 | (___  _ _ __ | |_     | |  | |__   ___  __
  \___ \| | '_ \| __|    | |  | '_ \ / _ \/ /
  ____) | | | | | |_     | |  | | | |  __/| |
 |_____/|_|_| |_|\__|    |_|  |_| |_|\___||_|
`;

const farewell = `
  _______ _            _____ _             
 |__   __| |          / ____(_)            
    | |  | |__   ___ | (___  _ _ __   __ _ 
    | |  | '_ \ / _ \ \___ \| | '_ \ / _\` |
    | |  | | | |  __/ ____) | | | | | (_| |
    |_|  |_| |_|\___||_____/|_|_| |_|\__, |
                                     __/ |
                                    |___/ 
`;

function animateASCII(text, speed) {
  const lines = text.split('\n');
  let index = 0;
  let reverse = false;

  setInterval(() => {
    console.clear();
    console.log(lines[index]);

    if (reverse && index === 0) {
      reverse = false;
    } else if (!reverse && index === lines.length - 1) {
      reverse = true;
    }

    if (reverse) {
      index--;
    } else {
      index++;
    }
  }, speed);
}

// Saludo
animateASCII(greeting, 2000);

// Despedida después de 5 segundos
setTimeout(() => {
  animateASCII(farewell, 2000);
}, 5000);

