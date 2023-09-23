import numpy as np
def AutoFloatProperties(*props):
	class _AutoFloatProperties(type):
		def __init__(cls, name, bases, cdict):
			super(_AutoFloatProperties, cls).__init__(name, bases, cdict)
			for attr in props:
				def fget(self, _attr='_'+attr): return getattr(self, _attr)
				def fset(self, value, _attr='_'+attr): setattr(self, _attr, float(value))
				setattr(cls, attr, property(fget, fset))
	return _AutoFloatProperties

class Vector():
	"""
		Vector class. Implemented:
		 - vector summ
		 - vector scalar multiplication
		 - vector vectorial multiplication
		 - vector multiplication by scalar value (left + right)
		 - vector negative
		 - all input converted to floats by a metaclass
	"""
	__metaclass__ = AutoFloatProperties('x','y','z')
	def __init__(self, vector):
		self.x, self.y, self.z = vector
	
	def __add__(self, other):
		"""Vector summing"""
		if isinstance(other, Vector):
			return Vector((self.x + other.x, self.y + other.y, self.z + other.z))
		else:
			raise TypeError('Vector can be added only to vector')
	
	def __sub__(self, other):
		"""Vector subtraction"""
		if isinstance(other, Vector):
			return Vector((self.x - other.x, self.y - other.y, self.z - other.z))
		else:
			raise TypeError('Vector can be subtracted only from vector')
	
	def __mul__(self, other):
		"""Scalar multiplication"""
		if (isinstance(other, Vector)):
			return self.x * other.x + self.y * other.y + self.z * other.z
		elif isinstance(other, (int, float)):
			return Vector((self.x * other, self.y * other, self.z * other))
		else:
			raise TypeError('Vector can be multiplied only by vector or scalar value (int, float)')
	
	def __rmul__(self, other):
		"""Scalar multiplication from the right side"""
		if isinstance(other, (int, float)):
			return Vector((self.x * other, self.y * other, self.z * other))
		else:
			raise TypeError('Vector right side multiplication only by scalar value (int, float)')
	
	def __pow__(self, other):
		"""Vector cross product"""
		if isinstance(other, Vector):
			return Vector(((self.y * other.z - self.z * other.y), (self.z * other.x - self.x * other.z), (self.x * other.y - self.y * other.x)))
		else:
			raise TypeError('Vector cross product can be done only with another vector')
	
	def __neg__(self):
		return self * (-1)
	
	def __abs__(self):
		"""Absolute vector value - length"""
		"""Can be replaced with """
		return np.sqrt(self * self)
	
	def __getitem__(self, index):
		"""Get value listwise"""
		data = [self.x, self.y, self.z]
		if index in range(3):
			return data[index]
		else:
			raise IndexError('Index error: [vector.x, vector.y, vector.z]')
	
	def __setitem__(self, key, item):
		"""Set value listwise"""
		if (key == 0):
			self.x = item
		elif (key == 1):
			self.y = item
		elif (key == 2):
			self.z = item
		else:
			raise IndexError('Index error: [vector.x, vector.y, vector.z]')
	
	def __repr__(self):
		return "(%.2f, %.2f, %.2f)" % (self.x, self.y, self.z)
	
	def unitize(self):
		"""Unit vector"""
		return Vector(self * (1 / abs(self)))

"""
	TODO: Implement Functions of a quaternion variable http://en.wikipedia.org/wiki/Quaternion
"""
import math

class Quaternion(object):
    def __init__(self, real = 0, i = 0, j = 0, k = 0):
        if type(real) == type(self):
            self.real = real.real
            self.i = real.i
            self.j = real.j
            self.k = real.k
        else:
            self.real = real
            self.i = 0
            self.j = 0
            self.k = 0

        if type(i) == type(self):
            self.real -= i.i
            self.i += i.real
            self.j += i.k
            self.k -= i.j
        elif type(real) != type(self):
            self.i = i

        if type(j) == type(self):
            self.real -= j.j
            self.i -= j.k
            self.j += j.real
            self.k += j.i
        elif type(real) != type(self):
            self.j = j

        if type(k) == type(self):
            self.real -= k.k
            self.i += k.j
            self.j -= k.i
            self.k += k.real
        elif type(real) != type(self):
            self.k = k

    def conjugate(self):
        return Quaternion(self.real, -self.i, -self.j, -self.k)

    def scalar_prod(self, other):
        result = (self.conjugate() * other + self * other.conjugate()) / 2
        if result.real != 0: return result.real
        elif result.i != 0: return  result.i
        elif result.j != 0: return result.j
        else: return result.k

    def vector_prod(self, other):
        return (self * other + other * self) / 2

    def __abs__(self):
        return math.sqrt(self.real * self.real +
                         self.i * self.i +
                         self.j * self.j +
                         self.k * self.k)

    def __truediv__(self, other):
        return Quaternion(self.real / other, self.i / other, self.j / other, self.k / other)

    def __neg__(self):
        return Quaternion(-self.real, -self.i, -self.j, -self.k)

    def __add__(self, other):
        other = Quaternion(other)
        return Quaternion(self.real + other.real,
                          self.i + other.i,
                          self.j + other.j,
                          self.k + other.k)

    def __radd__(self, other):
        return self + other

    def __sub__(self, other):
        return self + (-other)

    def __rsub__(self, other):
        return other + (-self)

    def __mul__(self, other):
        other = Quaternion(other)
        return Quaternion(self.real * other.real - self.i * other.i - self.j * other.j - self.k * other.k,
                          self.real * other.i + self.i * other.real + self.j * other.k - self.k * other.j,
                          self.real * other.j + self.j * other.real + self.k * other.i - self.i * other.k,
                          self.real * other.k + self.k * other.real + self.i * other.j - self.j * other.i)

    def __rmul__(self, other):
        other = Quaternion(other)
        return other * self

    def __eq__(self, other):
        other = Quaternion(other)
        return (self.real == other.real and
                self.i == other.i and
                self.j == other.j and
                self.k == other.k)

    def __ne__(self, other):
        return not (self == other)

    def __str__(self):
        return "%g%+gi%+gj%+gk" % (self.real, self.i, self.j, self.k)
