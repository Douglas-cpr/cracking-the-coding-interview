class MyStatck {
  private stack: string[]
  constructor() {
    this.stack = [] 
  }


  /** Add item in top of stack */
  public push(item: string) {
      var tmp = [];
      tmp.push(item);
      this.stack.forEach((i) => {
        tmp.push(i);
      })
      this.stack = tmp;
  }

  /** Remove item from top of stack */
  public pop(): string {
    if (this.isEmpty()) return ''
    var tmp = []
    this.stack.forEach((i: string, idx: number) => {
      if (idx != 0) tmp.push(i)
    })
    var el = this.stack[0]
    this.stack = tmp
    return el
  };

  /** Return the top of stack */
  public peek(): string {
    if (this.isEmpty()) return ''
    return this.stack[0]
  }

  /** Return true if and only if the stack is empty */
  public isEmpty(): boolean {
    if (this.stack.length == 0) return true
    return false
  }
}


function init() {
  var stack = new MyStatck();


  stack.push("1");
  stack.push("2");
  stack.push("3");

  console.log(stack.pop());
  stack.push("21");
}

init()