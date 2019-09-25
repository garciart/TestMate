﻿/*
 * The MIT License
 *
 * Copyright 2019 Rob Garcia at rgarcia@rgprogramming.com.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
using System;
using TestMate.Common;

namespace TestMate.Models {
    /// <summary>
    /// TestMate model class for key term data objects.
    /// </summary>
    public class KeyTermQuestion : Question {
        /// <summary>
        /// The key term; cannot be null.
        /// </summary>
        public string KeyTerm {
            get {
                return KeyTerm;
            }
            set {
                KeyTerm = value ?? throw new ArgumentNullException("Key terms cannot be null or empty.");
            }
        }
        
        /// <summary>
        /// The key term definition; cannot be null.
        /// </summary>
        public string Definition {
            get {
                return Definition;
            }
            set {
                Definition = value ?? throw new ArgumentNullException("Key term definitions cannot be null or empty.");
            }
        }

        public KeyTermQuestion() {
            QuestionType = Constants.QuestionType.K;
        }
    }
}
