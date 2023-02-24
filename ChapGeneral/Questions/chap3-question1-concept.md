# Approach

## Simple implementation

public class ThreeStacks {
  public ThreeStacks(int cap = 2) {
    cap = cap * 3  // 2
    this.items = [null] * cap
    this.start = [0, cap / 3, 2 * (cap / 3)]; // indicate where each stack starts, if we have 2 stacks for example only change 3 value to 2;
    this.end = [cap/3, 2*(cap/3), cap] // where each stack ends
  }

  push(stack, val) {
    if (stack > 2) throw error // stack is more than starter (3) 0,1,2
    if (this.start[stack] >= this.end[stack]) throw error // stack full
    this.items[this.start[stack]] = val
    this.start[stack] += 1 // increment start of stack
  }

  pop(stack) {
    if (stack > 2) throw error // stack is too big
    top = this.start[stack] - 1;
    item = this.items[top] 
    this.items[top] = none
    this.start[stack] = top
  }
}

- Cons:
  - limited stack size