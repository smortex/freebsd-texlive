# New ports collection makefile for:	texlive-csplain
# Date created:		13/03/2010 04:35:16
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	csplain
PORTVERSION=	20100921
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Plain TeX support for Czech/Slovak typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
