# New ports collection makefile for:	texlive-bin-latex
# Date created:		26/01/2009 16:03:01
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-latex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A TeX macro package that defines LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.luatex.cnf:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/latex.ini:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/fonts/afm/bluesky/latex-fonts/lasy10.afm:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
