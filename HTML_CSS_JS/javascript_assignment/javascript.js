// problem 1

let salaries = {
    john: 100,
    ann: 160,
    pete: 130
};

let salary_sum = 0;
for (const prop in salaries) {
    salary_sum += salaries[prop];
}

console.log(`the sum of salaries is : ${salary_sum}`)


// problem 2
let menu = {
    width: 200,
    height: 300,
    title: 'My menu'
};
console.log(`menu before change ${JSON.stringify(menu)}`)
multiplyNumberic(menu)

function multiplyNumberic(obj) {
    for (const prop in obj) {
        if (typeof obj[prop] == 'number') {
            obj[prop] = obj[prop] * 2;
        }
    }
}

console.log(`menu after change ${JSON.stringify(menu)}`)


// problem 3
function findMatch(str) {
    const re = new RegExp(".*@.+\\..*");
    return re.test(str);
}

let test1 = "jfjfpa. joif@"
let test2 = "@dfjo.dfsdf"
console.log(`Does ${test1} match the rule: ${findMatch(test1)}`);
console.log(`Does ${test2} match the rule: ${findMatch(test2)}`);


// problem 4

function truncate(str, num) {
    if (str.length < num) {
        return str;
    }
    let new_str = str.substring(0, num);
    return new_str + "...";
}

test1 = "What I'd like to tell on this topic is:";
console.log(`${test1} -> ${truncate(test1, 20)}`)
test2 = "Hi everyone!";
console.log(`${test2} -> ${truncate(test2, 20)}`)


//problem 5
const names = [];
names.push("James");
names.push("Bernnie");
names.push("Robert");
names[1] = "Calvin";
names.pop();
names.splice(0, 0, "Regal");
names.splice(0, 0, "Rose");
console.log(`names: ${names}`)

