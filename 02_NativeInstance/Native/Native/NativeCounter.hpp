//
//  NativeCounter.hpp
//  Native
//
//  Created by Shogo Nakamura on 2017/10/26.
//  Copyright © 2017 com.shogonir. All rights reserved.
//

#ifndef NativeCounter_hpp
#define NativeCounter_hpp

#include <stdio.h>

class NativeCounter
{
public:
    NativeCounter();
    ~NativeCounter();
    void Increment();
    int GetCount();
    
private:
    int count;
};

#endif /* NativeCounter_hpp */
