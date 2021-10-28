"""
pcの価格計算
"""

parts = {}

parts['cpu'] = ('Core i5 10400', 20480)
# parts['cpu'] = ('Core i5 10400F', 18675)

# Intel
parts['motherboard'] = ('ATX Intel H470 LGA1200', 12882)

# AMD
# parts['motherboard'] = ('ATX AMD B450 SocketAM4', 7980)
# parts['motherboard'] = ('ATX AMD B550 SocketAM4', 11861)

parts['main_memory'] = ('DDR4 PC4-21300 16GB x2', 10980)
parts['gpu'] = ('RTX2070 SUPER VRAM 8GB', 48950) # hdmi x1, dp x3
parts['power'] = ('750W', 7238)
parts['case'] = ('ATX', 3938)
parts['ssd'] = ('none', 0)
parts['hdd'] = ('5TB 7200rpm', 8800) # 東芝製
parts['sata_cable'] = ('sataケーブル3本セット', 1000)
parts['os'] = ('Windows10 Home', 17527) # 通常版

# total = 0

# for key, val in parts.items():
#     total += val[1]
#     print(key + ':' + val[0] + ' ' + '{:,d}'.format(val[1]) + '円')

# print('合計価格:' + '{:,d}'.format(total) + '円')
