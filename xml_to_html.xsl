<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"> </xsl:output>


	<xsl:template match="/">
		<html>
			<body>
				<table>
					<tr>
						<th>author</th>
						<th>name</th>
						<th>faculty</th>
						<th>cathedra</th>
						<th>size</th>
						<th>date of creating</th>
					</tr>
					<xsl:for-each select = "archive/material">
						<tr>
							<td>
								<xsl:value-of select ="@author"/>
							</td>
							<td>
								<xsl:value-of select ="@name"/>
							</td>
							<td>
								<xsl:value-of select ="@faculty"/>
							</td>
							<td>
								<xsl:value-of select ="@cathedra"/>
							</td>
							<td>
								<xsl:value-of select ="@size"/>
							</td>
							<td>
								<xsl:value-of select ="@dateofCreating"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>