# New ports collection makefile for:	texlive-metafont
# Date created:		13/03/2010 04:19:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	metafont
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A system for specifying fonts.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
