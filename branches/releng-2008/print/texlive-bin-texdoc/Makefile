# New ports collection makefile for:	texlive-bin-texdoc
# Date created:		26/01/2009 16:03:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-texdoc
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Documentation access for TeX distributions.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
