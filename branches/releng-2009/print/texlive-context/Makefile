# New ports collection makefile for:	texlive-context
# Date created:		13/03/2010 04:21:16
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The ConTeXt macro package.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm \
		${LOCALBASE}/share/texmf-dist/tex/context/base/supp-pdf.tex:${PORTSDIR}/print/texlive-supp-pdf \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
