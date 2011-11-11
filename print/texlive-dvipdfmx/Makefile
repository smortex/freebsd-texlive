# New ports collection makefile for:	texlive-dvipdfmx
# Date created:		13/03/2010 04:19:32
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dvipdfmx
PORTVERSION=	20111111
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	An extended version of dvipdfm.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
