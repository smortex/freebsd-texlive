# New ports collection makefile for:	texlive-latex
# Date created:		13/03/2010 04:20:30
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	latex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A TeX macro package that defines LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/tex/generic/config/luatexiniconfig.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/color.cfg:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
